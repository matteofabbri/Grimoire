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
	public class Change_Emergency_Contact_DataType : INotifyPropertyChanged
	{
		private string emergency_Contact_IDField;

		private bool primaryField;

		private bool primaryFieldSpecified;

		private decimal priorityField;

		private Related_Person_RelationshipObjectType[] related_Person_Relationship_ReferenceField;

		private LanguageObjectType[] language_ReferenceField;

		private Emergency_Contact_Personal_Information_DataType emergency_Contact_Personal_Information_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Emergency_Contact_ID
		{
			get
			{
				return this.emergency_Contact_IDField;
			}
			set
			{
				this.emergency_Contact_IDField = value;
				this.RaisePropertyChanged("Emergency_Contact_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Primary
		{
			get
			{
				return this.primaryField;
			}
			set
			{
				this.primaryField = value;
				this.RaisePropertyChanged("Primary");
			}
		}

		[XmlIgnore]
		public bool PrimarySpecified
		{
			get
			{
				return this.primaryFieldSpecified;
			}
			set
			{
				this.primaryFieldSpecified = value;
				this.RaisePropertyChanged("PrimarySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
				this.RaisePropertyChanged("Priority");
			}
		}

		[XmlElement("Related_Person_Relationship_Reference", Order = 3)]
		public Related_Person_RelationshipObjectType[] Related_Person_Relationship_Reference
		{
			get
			{
				return this.related_Person_Relationship_ReferenceField;
			}
			set
			{
				this.related_Person_Relationship_ReferenceField = value;
				this.RaisePropertyChanged("Related_Person_Relationship_Reference");
			}
		}

		[XmlElement("Language_Reference", Order = 4)]
		public LanguageObjectType[] Language_Reference
		{
			get
			{
				return this.language_ReferenceField;
			}
			set
			{
				this.language_ReferenceField = value;
				this.RaisePropertyChanged("Language_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Emergency_Contact_Personal_Information_DataType Emergency_Contact_Personal_Information_Data
		{
			get
			{
				return this.emergency_Contact_Personal_Information_DataField;
			}
			set
			{
				this.emergency_Contact_Personal_Information_DataField = value;
				this.RaisePropertyChanged("Emergency_Contact_Personal_Information_Data");
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
