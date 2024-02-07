using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Renewal_Terms_DataType : INotifyPropertyChanged
	{
		private bool automatically_RenewField;

		private bool automatically_RenewFieldSpecified;

		private bool send_Expiration_NotificationField;

		private bool send_Expiration_NotificationFieldSpecified;

		private decimal notice_PeriodField;

		private bool notice_PeriodFieldSpecified;

		private Unit_of_Time_for_ProcurementObjectType notice_Period_Frequency_ReferenceField;

		private decimal renewal_TermField;

		private bool renewal_TermFieldSpecified;

		private Unit_of_Time_for_ProcurementObjectType renewal_Term_Frequency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Automatically_Renew
		{
			get
			{
				return this.automatically_RenewField;
			}
			set
			{
				this.automatically_RenewField = value;
				this.RaisePropertyChanged("Automatically_Renew");
			}
		}

		[XmlIgnore]
		public bool Automatically_RenewSpecified
		{
			get
			{
				return this.automatically_RenewFieldSpecified;
			}
			set
			{
				this.automatically_RenewFieldSpecified = value;
				this.RaisePropertyChanged("Automatically_RenewSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Send_Expiration_Notification
		{
			get
			{
				return this.send_Expiration_NotificationField;
			}
			set
			{
				this.send_Expiration_NotificationField = value;
				this.RaisePropertyChanged("Send_Expiration_Notification");
			}
		}

		[XmlIgnore]
		public bool Send_Expiration_NotificationSpecified
		{
			get
			{
				return this.send_Expiration_NotificationFieldSpecified;
			}
			set
			{
				this.send_Expiration_NotificationFieldSpecified = value;
				this.RaisePropertyChanged("Send_Expiration_NotificationSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Notice_Period
		{
			get
			{
				return this.notice_PeriodField;
			}
			set
			{
				this.notice_PeriodField = value;
				this.RaisePropertyChanged("Notice_Period");
			}
		}

		[XmlIgnore]
		public bool Notice_PeriodSpecified
		{
			get
			{
				return this.notice_PeriodFieldSpecified;
			}
			set
			{
				this.notice_PeriodFieldSpecified = value;
				this.RaisePropertyChanged("Notice_PeriodSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Unit_of_Time_for_ProcurementObjectType Notice_Period_Frequency_Reference
		{
			get
			{
				return this.notice_Period_Frequency_ReferenceField;
			}
			set
			{
				this.notice_Period_Frequency_ReferenceField = value;
				this.RaisePropertyChanged("Notice_Period_Frequency_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Renewal_Term
		{
			get
			{
				return this.renewal_TermField;
			}
			set
			{
				this.renewal_TermField = value;
				this.RaisePropertyChanged("Renewal_Term");
			}
		}

		[XmlIgnore]
		public bool Renewal_TermSpecified
		{
			get
			{
				return this.renewal_TermFieldSpecified;
			}
			set
			{
				this.renewal_TermFieldSpecified = value;
				this.RaisePropertyChanged("Renewal_TermSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Unit_of_Time_for_ProcurementObjectType Renewal_Term_Frequency_Reference
		{
			get
			{
				return this.renewal_Term_Frequency_ReferenceField;
			}
			set
			{
				this.renewal_Term_Frequency_ReferenceField = value;
				this.RaisePropertyChanged("Renewal_Term_Frequency_Reference");
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
