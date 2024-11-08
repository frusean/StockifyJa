﻿using System;
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

            string path = @"";// Replace with your actual file path
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            db = FirestoreDb.Create("stockify-34d8d");
            collectionReference = db.Collection("conversations");
            frmAdminChatInstance = this;
        }



        private bool isFirstSnapshot = true;
        private void StartListening()
        {
            // Subtract 1 second from the current time to account for delay
            DateTime timeCutoff = DateTime.UtcNow.AddSeconds(-1);
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

      
        private void lbxAdminMessageView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAdminMessageInput_TextChanged(object sender, EventArgs e)
        {

        }



       
       

        private void FrmAdminChat_Load(object sender, EventArgs e)
        {
            lbxAdminMessageView.Items.Clear();
            StartListening();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void picSend_Click(object sender, EventArgs e)
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

            // Check the customer chat instance and re-create it if necessary
            if (FrmCustomerChat.frmCustomerChatInstance == null || FrmCustomerChat.frmCustomerChatInstance.IsDisposed)
            {
                FrmCustomerChat.frmCustomerChatInstance = new FrmCustomerChat();
                FrmCustomerChat.frmCustomerChatInstance.Show();
            }
        }
    }
}
