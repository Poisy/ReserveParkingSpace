using System;

namespace WebUI.Models
{
    /// <summary> Auto generated model for the error view. </summary>
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}