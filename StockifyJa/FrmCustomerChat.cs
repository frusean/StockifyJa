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
    public partial class FrmCustomerChat : Form
    {
        private FirestoreDb db;
        private CollectionReference collectionReference;
        private FirestoreChangeListener listener;
        private HashSet<string> seenDocumentIds = new HashSet<string>();
        public static FrmAdminChat frmAdminChatInstance = new FrmAdminChat();
        public static FrmCustomerChat frmCustomerChatInstance;
        private DateTime chatOpenedAt;

        public FrmCustomerChat()
        {
            InitializeComponent();
            chatOpenedAt = DateTime.UtcNow;

            string path = @"C:\Users\fruse\Downloads\StockifyJa\StockifyJa\stockify-34d8d-firebase-adminsdk-xrgx1-2368fde9a0.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("stockify-34d8d");
            collectionReference = db.Collection("conversations");
            frmCustomerChatInstance = this;
        }

        public void AddMessage(string message)
        {
            lbxCustomerMessageView.Items.Add(message);
        }



        private void StartListening()
        {
            Query query = collectionReference.OrderBy("Timestamp");
            listener = query.Listen(snapshot =>
            {
                BeginInvoke((Action)(() =>
                {
                    foreach (DocumentChange change in snapshot.Changes)
                    {
                        string documentId = change.Document.Id;
                        if (seenDocumentIds.Contains(documentId))
                        {
                            continue;
                        }

                        seenDocumentIds.Add(documentId);

                        Dictionary<string, object> data = change.Document.ToDictionary();
                        string author = data["Author"].ToString();
                        string message = data["Message"].ToString();
                        DateTime timestamp = ((Timestamp)data["Timestamp"]).ToDateTime();

                        if (timestamp.ToUniversalTime() <= chatOpenedAt)
                        {
                            continue;
                        }

                        lbxCustomerMessageView.Items.Add($"[{timestamp.ToString("hh:mm tt")}] {author}: {message}");
                    }
                }));
            });
        }




        private void txtCustomerMessageInput_TextChanged(object sender, EventArgs e)
        {

        }




        private async void btnCustomerMessageSendButton_Click(object sender, EventArgs e)
        {
            string message = txtCustomerMessageInput.Text;

            Dictionary<string, object> docData = new Dictionary<string, object>
        {
            { "Author", "Customer" },
            { "Message", message },
            { "Timestamp", Timestamp.GetCurrentTimestamp() }
        };
            await collectionReference.AddAsync(docData);

            txtCustomerMessageInput.Clear();

            if (FrmAdminChat.frmAdminChatInstance.IsDisposed)
            {
                FrmAdminChat.frmAdminChatInstance = new FrmAdminChat();
            }

               FrmAdminChat.frmAdminChatInstance.Show(); // Show the Admin Chat form
        }


        private void FrmCustomerChat_Load(object sender, EventArgs e)
        {
            StartListening();
        }


        private void lbxCustomerMessageView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}








