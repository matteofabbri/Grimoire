using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Committee_Definition_DataType : INotifyPropertyChanged
	{
		private string idField;

		private bool private_CommitteeField;

		private bool private_CommitteeFieldSpecified;

		private bool include_Code_in_NameField;

		private bool include_Code_in_NameFieldSpecified;

		private Committee_TypeObjectType committee_Type_ReferenceField;

		private bool include_Type_in_NameField;

		private bool include_Type_in_NameFieldSpecified;

		private Organization_SubtypeObjectType committee_Subtype_ReferenceField;

		private bool include_Subtype_in_NameField;

		private bool include_Subtype_in_NameFieldSpecified;

		private Committee_ClassificationObjectType[] committee_Classifications_ReferenceField;

		private bool publishableField;

		private bool publishableFieldSpecified;

		private External_URLObjectType external_URL_ReferenceField;

		private Committee_Attachment_DataType[] committee_Attachment_DataField;

		private Committee_Definition_Snapshot_DataType committee_Definition_Snapshot_DataField;

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
		public bool Private_Committee
		{
			get
			{
				return this.private_CommitteeField;
			}
			set
			{
				this.private_CommitteeField = value;
				this.RaisePropertyChanged("Private_Committee");
			}
		}

		[XmlIgnore]
		public bool Private_CommitteeSpecified
		{
			get
			{
				return this.private_CommitteeFieldSpecified;
			}
			set
			{
				this.private_CommitteeFieldSpecified = value;
				this.RaisePropertyChanged("Private_CommitteeSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Code_in_Name
		{
			get
			{
				return this.include_Code_in_NameField;
			}
			set
			{
				this.include_Code_in_NameField = value;
				this.RaisePropertyChanged("Include_Code_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Code_in_NameSpecified
		{
			get
			{
				return this.include_Code_in_NameFieldSpecified;
			}
			set
			{
				this.include_Code_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Code_in_NameSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Committee_TypeObjectType Committee_Type_Reference
		{
			get
			{
				return this.committee_Type_ReferenceField;
			}
			set
			{
				this.committee_Type_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Type_in_Name
		{
			get
			{
				return this.include_Type_in_NameField;
			}
			set
			{
				this.include_Type_in_NameField = value;
				this.RaisePropertyChanged("Include_Type_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Type_in_NameSpecified
		{
			get
			{
				return this.include_Type_in_NameFieldSpecified;
			}
			set
			{
				this.include_Type_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Type_in_NameSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Organization_SubtypeObjectType Committee_Subtype_Reference
		{
			get
			{
				return this.committee_Subtype_ReferenceField;
			}
			set
			{
				this.committee_Subtype_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Subtype_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public bool Include_Subtype_in_Name
		{
			get
			{
				return this.include_Subtype_in_NameField;
			}
			set
			{
				this.include_Subtype_in_NameField = value;
				this.RaisePropertyChanged("Include_Subtype_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Subtype_in_NameSpecified
		{
			get
			{
				return this.include_Subtype_in_NameFieldSpecified;
			}
			set
			{
				this.include_Subtype_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Subtype_in_NameSpecified");
			}
		}

		[XmlElement("Committee_Classifications_Reference", Order = 7)]
		public Committee_ClassificationObjectType[] Committee_Classifications_Reference
		{
			get
			{
				return this.committee_Classifications_ReferenceField;
			}
			set
			{
				this.committee_Classifications_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Classifications_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public bool Publishable
		{
			get
			{
				return this.publishableField;
			}
			set
			{
				this.publishableField = value;
				this.RaisePropertyChanged("Publishable");
			}
		}

		[XmlIgnore]
		public bool PublishableSpecified
		{
			get
			{
				return this.publishableFieldSpecified;
			}
			set
			{
				this.publishableFieldSpecified = value;
				this.RaisePropertyChanged("PublishableSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public External_URLObjectType External_URL_Reference
		{
			get
			{
				return this.external_URL_ReferenceField;
			}
			set
			{
				this.external_URL_ReferenceField = value;
				this.RaisePropertyChanged("External_URL_Reference");
			}
		}

		[XmlElement("Committee_Attachment_Data", Order = 10)]
		public Committee_Attachment_DataType[] Committee_Attachment_Data
		{
			get
			{
				return this.committee_Attachment_DataField;
			}
			set
			{
				this.committee_Attachment_DataField = value;
				this.RaisePropertyChanged("Committee_Attachment_Data");
			}
		}

		[XmlElement(Order = 11)]
		public Committee_Definition_Snapshot_DataType Committee_Definition_Snapshot_Data
		{
			get
			{
				return this.committee_Definition_Snapshot_DataField;
			}
			set
			{
				this.committee_Definition_Snapshot_DataField = value;
				this.RaisePropertyChanged("Committee_Definition_Snapshot_Data");
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
