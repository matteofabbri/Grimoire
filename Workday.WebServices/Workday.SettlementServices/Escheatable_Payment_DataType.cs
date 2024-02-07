using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Escheatable_Payment_DataType : INotifyPropertyChanged
	{
		private string idField;

		private DateTime payment_Notification_DateField;

		private bool payment_Notification_DateFieldSpecified;

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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Payment_Notification_Date
		{
			get
			{
				return this.payment_Notification_DateField;
			}
			set
			{
				this.payment_Notification_DateField = value;
				this.RaisePropertyChanged("Payment_Notification_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_Notification_DateSpecified
		{
			get
			{
				return this.payment_Notification_DateFieldSpecified;
			}
			set
			{
				this.payment_Notification_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Notification_DateSpecified");
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
