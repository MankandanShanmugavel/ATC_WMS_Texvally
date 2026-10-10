using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATC_WMS.Model;
using UIPShared;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Printing;

namespace ATC_WMS
{
    public partial class frmDecodeEncode : Form
    {
        public frmDecodeEncode()
        {
            InitializeComponent();
        }
        private void btnEncoded_Click(object sender, EventArgs e)
        {
            // Get the text from txtencode
            string inputText = txtEncoded.Text;
            txtResulted.Text = EncodePasswordToBase64(inputText);
        }

        private void btnDecoded_Click(object sender, EventArgs e)
        {
            // Get the text from txtdecode
            string inputText = txtDecoded.Text;
            // Display the decoded text in txtResult
            txtResulted.Text = EncodePasswordToBase64(inputText);

        }

        public static string EncodePasswordToBase64(string decodeData)
        {
            try
            {
                byte[] encData_byte = new byte[decodeData.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(decodeData);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        public string DecodeFrom64(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }


    }
    }

