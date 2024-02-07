using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Integration_Transport_Protocol_Data_WWSType : INotifyPropertyChanged
	{
		private string idField;

		private object itemField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement("AS2_Transport_Protocol_Data", typeof(AS2_Transport_Protocol_DataType), Order = 1), XmlElement("Email_Transport_Protocol_Data", typeof(Email_Transport_Protocol_DataType), Order = 1), XmlElement("Extensibility_API_Transport_Protocol_Data", typeof(EIB_Extensibility_API_Transport_Protocol_DataType), Order = 1), XmlElement("FTPS_Transport_Protocol_Data", typeof(FTPS_Transport_Protocol_DataType), Order = 1), XmlElement("FTP_Transport_Protocol_Data", typeof(FTP_Transport_Protocol_DataType), Order = 1), XmlElement("HTTP_Transport_Protocol_Data", typeof(HTTP_Transport_Protocol_DataType), Order = 1), XmlElement("SFTP_Transport_Protocol_Data", typeof(SFTP_Transport_Protocol_DataType), Order = 1), XmlElement("Workday_Attachment_Transport_Protocol_Data", typeof(Workday_Attachment_Transport_Protocol_DataType), Order = 1), XmlElement("Workday_Web_Service_Transport_Protocol_Data", typeof(Workday_Web_Service_Transport_Protocol_DataType), Order = 1)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
