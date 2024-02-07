using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Subaward_DataType : INotifyPropertyChanged
	{
		private string subaward_IDField;

		private Award_ContractObjectType award_Contract_ReferenceField;

		private Award_Contract_LineObjectType award_Contract_Line_ReferenceField;

		private Subrecipient_AbstractObjectType subrecipient_ReferenceField;

		private LocationObjectType[] location_ReferenceField;

		private Subject_to_FFATAObjectType subject_to_FFATA_ReferenceField;

		private decimal fFATA_AmountField;

		private bool fFATA_AmountFieldSpecified;

		private Financials_Attachment_DataType[] attachment_DataField;

		private Subaward_Business_Entity_Contact_DataType[] subaward_Contact_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Subaward_ID
		{
			get
			{
				return this.subaward_IDField;
			}
			set
			{
				this.subaward_IDField = value;
				this.RaisePropertyChanged("Subaward_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Award_ContractObjectType Award_Contract_Reference
		{
			get
			{
				return this.award_Contract_ReferenceField;
			}
			set
			{
				this.award_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Award_Contract_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Award_Contract_LineObjectType Award_Contract_Line_Reference
		{
			get
			{
				return this.award_Contract_Line_ReferenceField;
			}
			set
			{
				this.award_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Award_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Subrecipient_AbstractObjectType Subrecipient_Reference
		{
			get
			{
				return this.subrecipient_ReferenceField;
			}
			set
			{
				this.subrecipient_ReferenceField = value;
				this.RaisePropertyChanged("Subrecipient_Reference");
			}
		}

		[XmlElement("Location_Reference", Order = 4)]
		public LocationObjectType[] Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Subject_to_FFATAObjectType Subject_to_FFATA_Reference
		{
			get
			{
				return this.subject_to_FFATA_ReferenceField;
			}
			set
			{
				this.subject_to_FFATA_ReferenceField = value;
				this.RaisePropertyChanged("Subject_to_FFATA_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal FFATA_Amount
		{
			get
			{
				return this.fFATA_AmountField;
			}
			set
			{
				this.fFATA_AmountField = value;
				this.RaisePropertyChanged("FFATA_Amount");
			}
		}

		[XmlIgnore]
		public bool FFATA_AmountSpecified
		{
			get
			{
				return this.fFATA_AmountFieldSpecified;
			}
			set
			{
				this.fFATA_AmountFieldSpecified = value;
				this.RaisePropertyChanged("FFATA_AmountSpecified");
			}
		}

		[XmlElement("Attachment_Data", Order = 7)]
		public Financials_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
			}
		}

		[XmlElement("Subaward_Contact_Data", Order = 8)]
		public Subaward_Business_Entity_Contact_DataType[] Subaward_Contact_Data
		{
			get
			{
				return this.subaward_Contact_DataField;
			}
			set
			{
				this.subaward_Contact_DataField = value;
				this.RaisePropertyChanged("Subaward_Contact_Data");
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
