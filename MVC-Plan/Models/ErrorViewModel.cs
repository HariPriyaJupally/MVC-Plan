using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Plan.Models
{
    public class ErrorViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}