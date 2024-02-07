using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Basic_Gift_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string gift_NameField;

		private bool include_Gift_ID_in_NameField;

		private bool include_Gift_ID_in_NameFieldSpecified;

		private Gift_TypeObjectType gift_Type_ReferenceField;

		private Gift_PurposeObjectType[] gift_Purpose_ReferenceField;

		private Related_Worktags_by_Worktag_Type_DataType[] related_Worktags_DataField;

		private bool gift_is_InactiveField;

		private bool gift_is_InactiveFieldSpecified;

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
		public string Gift_Name
		{
			get
			{
				return this.gift_NameField;
			}
			set
			{
				this.gift_NameField = value;
				this.RaisePropertyChanged("Gift_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Gift_ID_in_Name
		{
			get
			{
				return this.include_Gift_ID_in_NameField;
			}
			set
			{
				this.include_Gift_ID_in_NameField = value;
				this.RaisePropertyChanged("Include_Gift_ID_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Gift_ID_in_NameSpecified
		{
			get
			{
				return this.include_Gift_ID_in_NameFieldSpecified;
			}
			set
			{
				this.include_Gift_ID_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Gift_ID_in_NameSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Gift_TypeObjectType Gift_Type_Reference
		{
			get
			{
				return this.gift_Type_ReferenceField;
			}
			set
			{
				this.gift_Type_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Type_Reference");
			}
		}

		[XmlElement("Gift_Purpose_Reference", Order = 4)]
		public Gift_PurposeObjectType[] Gift_Purpose_Reference
		{
			get
			{
				return this.gift_Purpose_ReferenceField;
			}
			set
			{
				this.gift_Purpose_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Purpose_Reference");
			}
		}

		[XmlArray(Order = 5), XmlArrayItem("Related_Worktags_by_Type_Data", IsNullable = false)]
		public Related_Worktags_by_Worktag_Type_DataType[] Related_Worktags_Data
		{
			get
			{
				return this.related_Worktags_DataField;
			}
			set
			{
				this.related_Worktags_DataField = value;
				this.RaisePropertyChanged("Related_Worktags_Data");
			}
		}

		[XmlElement(Order = 6)]
		public bool Gift_is_Inactive
		{
			get
			{
				return this.gift_is_InactiveField;
			}
			set
			{
				this.gift_is_InactiveField = value;
				this.RaisePropertyChanged("Gift_is_Inactive");
			}
		}

		[XmlIgnore]
		public bool Gift_is_InactiveSpecified
		{
			get
			{
				return this.gift_is_InactiveFieldSpecified;
			}
			set
			{
				this.gift_is_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Gift_is_InactiveSpecified");
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
