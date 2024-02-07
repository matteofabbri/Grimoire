using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Recruiting_Agency_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string nameField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private string descriptionField;

		private Recruiting_Agency_TypeObjectType[] type_ReferenceField;

		private Recruiting_Agency_SiteObjectType superior_ReferenceField;

		private Contact_Information_DataType contact_Information_DataField;

		private Recruiting_Agency_Career_Site_Configuration_DataType recruiting_Agency_Career_Site_Configuration_DataField;

		private Recruiting_Agency_Payout_Terms_DataType recruiting_Agency_Payout_Terms_DataField;

		private Attachment_WWS_DataType[] recruiting_Agency_Attachment_DataField;

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

		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement("Type_Reference", Order = 4)]
		public Recruiting_Agency_TypeObjectType[] Type_Reference
		{
			get
			{
				return this.type_ReferenceField;
			}
			set
			{
				this.type_ReferenceField = value;
				this.RaisePropertyChanged("Type_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Recruiting_Agency_SiteObjectType Superior_Reference
		{
			get
			{
				return this.superior_ReferenceField;
			}
			set
			{
				this.superior_ReferenceField = value;
				this.RaisePropertyChanged("Superior_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Contact_Information_DataType Contact_Information_Data
		{
			get
			{
				return this.contact_Information_DataField;
			}
			set
			{
				this.contact_Information_DataField = value;
				this.RaisePropertyChanged("Contact_Information_Data");
			}
		}

		[XmlElement(Order = 7)]
		public Recruiting_Agency_Career_Site_Configuration_DataType Recruiting_Agency_Career_Site_Configuration_Data
		{
			get
			{
				return this.recruiting_Agency_Career_Site_Configuration_DataField;
			}
			set
			{
				this.recruiting_Agency_Career_Site_Configuration_DataField = value;
				this.RaisePropertyChanged("Recruiting_Agency_Career_Site_Configuration_Data");
			}
		}

		[XmlElement(Order = 8)]
		public Recruiting_Agency_Payout_Terms_DataType Recruiting_Agency_Payout_Terms_Data
		{
			get
			{
				return this.recruiting_Agency_Payout_Terms_DataField;
			}
			set
			{
				this.recruiting_Agency_Payout_Terms_DataField = value;
				this.RaisePropertyChanged("Recruiting_Agency_Payout_Terms_Data");
			}
		}

		[XmlArray(Order = 9), XmlArrayItem("Attachment_Data", typeof(Attachment_WWS_DataType), IsNullable = false)]
		public Attachment_WWS_DataType[] Recruiting_Agency_Attachment_Data
		{
			get
			{
				return this.recruiting_Agency_Attachment_DataField;
			}
			set
			{
				this.recruiting_Agency_Attachment_DataField = value;
				this.RaisePropertyChanged("Recruiting_Agency_Attachment_Data");
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
