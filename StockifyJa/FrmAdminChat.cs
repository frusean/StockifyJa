using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Api;
using Google.Cloud.Firestore;
namespace StockifyJa
{


    public partial class FrmAdminChat : Form
    {
        private FirestoreDb db;
        private CollectionReference collectionReference;
        private FirestoreChangeListener listener;
        private HashSet<string> seenDocumentIds = new HashSet<string>();
        public static FrmAdminChat frmAdminChatInstance;
        private DateTime chatOpenedAt;

        public FrmAdminChat()
        {
            InitializeComponent();
            chatOpenedAt = DateTime.UtcNow;

            string path = @"C:\Users\fruse\Downloads\StockifyJa\StockifyJa\stockify-34d8d-firebase-adminsdk-xrgx1-2368fde9a0.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("stockify-34d8d");
            collectionReference = db.Collection("conversations");
            frmAdminChatInstance = this;
        }



        private bool isFirstSnapshot = true;
        private void StartListening()
        {
            DateTime timeCutoff = DateTime.UtcNow.AddDays(-1); // Only show messages from the last 24 hours
            Query query = collectionReference.WhereGreaterThanOrEqualTo("Timestamp", Timestamp.FromDateTime(timeCutoff)).OrderBy("Timestamp");

            listener = query.Listen(snapshot =>
            {
                BeginInvoke((Action)(() =>
                {
                    foreach (DocumentChange change in snapshot.Changes)
                    {
                        Dictionary<string, object> data = change.Document.ToDictionary();
                        string author = data["Author"].ToString();
                        string message = data["Message"].ToString();
                        DateTime timestamp = ((Timestamp)data["Timestamp"]).ToDateTime();

                        lbxAdminMessageView.Items.Add($"[{timestamp.ToString("hh:mm tt")}] {author}: {message}");
                    }
                }));
            });
        }

        //private void StartListening()
        //{
        //    Query query = collectionReference.OrderBy("Timestamp");
        //    listener = query.Listen(snapshot =>
        //    {
        //        BeginInvoke((Action)(() =>
        //        {
        //            foreach (DocumentChange change in snapshot.Changes)
        //            {
        //                // if (change.Type == DocumentChange.Type.Added)
        //                {
        //                    Dictionary<string, object> data = change.Document.ToDictionary();
        //                    string author = data["Author"].ToString();
        //                    string message = data["Message"].ToString();
        //                    DateTime timestamp = ((Timestamp)data["Timestamp"]).ToDateTime();

        //                    if (timestamp.ToUniversalTime() <= chatOpenedAt)
        //                    {
        //                        continue;
        //                    }

        //                    lbxAdminMessageView.Items.Add($"[{timestamp.ToString("hh:mm tt")}] {author}: {message}");
        //                }
        //            }
        //        }));
        //    });
        //}

        private void lbxAdminMessageView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAdminMessageInput_TextChanged(object sender, EventArgs e)
        {

        }


        //private async void btnAdminMessageSendButton_Click(object sender, EventArgs e)
        //{
        //    string message = txtAdminMessageInput.Text;

        //    Dictionary<string, object> docData = new Dictionary<string, object>
        //{
        //    { "Author", "Admin" },
        //    { "Message", message },
        //    { "Timestamp", Timestamp.GetCurrentTimestamp() }
        //};
        //    await collectionReference.AddAsync(docData);

        //    txtAdminMessageInput.Clear();

        //    if (FrmCustomerChat.frmCustomerChatInstance.IsDisposed)
        //    {
        //        FrmCustomerChat.frmCustomerChatInstance = new FrmCustomerChat();
        //    }

        //   // FrmCustomerChat.frmCustomerChatInstance.Show(); // Show the Customer Chat form
        //}
        private async void btnAdminMessageSendButton_Click(object sender, EventArgs e)
        {
            string message = txtAdminMessageInput.Text;

            FirestoreDb db = FirestoreDb.Create("stockify-34d8d"); // create a new instance every time
            CollectionReference collectionReference = db.Collection("conversations");

            Dictionary<string, object> docData = new Dictionary<string, object>
    {
        { "Author", "Admin" },
        { "Message", message },
        { "Timestamp", Timestamp.GetCurrentTimestamp() }
    };
            await collectionReference.AddAsync(docData);

            txtAdminMessageInput.Clear();

            //if (FrmCustomerChat.frmCustomerChatInstance.IsDisposed)
            //{
            //    FrmCustomerChat.frmCustomerChatInstance = new FrmCustomerChat();

            //}
            if (FrmCustomerChat.frmCustomerChatInstance == null || FrmCustomerChat.frmCustomerChatInstance.IsDisposed)
            {
                FrmCustomerChat.frmCustomerChatInstance = new FrmCustomerChat();
            }

        }


        private void FrmAdminChat_Load(object sender, EventArgs e)
        {
            lbxAdminMessageView.Items.Clear();
            StartListening();
        }
    }
}
