using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Related_Worktags_by_Worktag_Type_DataType : INotifyPropertyChanged
	{
		private Accounting_Worktag_TypeObjectType worktag_Type_ReferenceField;

		private bool required_On_TransactionField;

		private bool required_On_TransactionFieldSpecified;

		private bool required_On_Transaction_For_ValidationField;

		private bool required_On_Transaction_For_ValidationFieldSpecified;

		private Default_Worktag_DataType default_Worktag_DataField;

		private bool replace_All_Allowed_ValuesField;

		private bool replace_All_Allowed_ValuesFieldSpecified;

		private Allowed_Worktag_DataType[] allowed_Worktag_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Accounting_Worktag_TypeObjectType Worktag_Type_Reference
		{
			get
			{
				return this.worktag_Type_ReferenceField;
			}
			set
			{
				this.worktag_Type_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Required_On_Transaction
		{
			get
			{
				return this.required_On_TransactionField;
			}
			set
			{
				this.required_On_TransactionField = value;
				this.RaisePropertyChanged("Required_On_Transaction");
			}
		}

		[XmlIgnore]
		public bool Required_On_TransactionSpecified
		{
			get
			{
				return this.required_On_TransactionFieldSpecified;
			}
			set
			{
				this.required_On_TransactionFieldSpecified = value;
				this.RaisePropertyChanged("Required_On_TransactionSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Required_On_Transaction_For_Validation
		{
			get
			{
				return this.required_On_Transaction_For_ValidationField;
			}
			set
			{
				this.required_On_Transaction_For_ValidationField = value;
				this.RaisePropertyChanged("Required_On_Transaction_For_Validation");
			}
		}

		[XmlIgnore]
		public bool Required_On_Transaction_For_ValidationSpecified
		{
			get
			{
				return this.required_On_Transaction_For_ValidationFieldSpecified;
			}
			set
			{
				this.required_On_Transaction_For_ValidationFieldSpecified = value;
				this.RaisePropertyChanged("Required_On_Transaction_For_ValidationSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Default_Worktag_DataType Default_Worktag_Data
		{
			get
			{
				return this.default_Worktag_DataField;
			}
			set
			{
				this.default_Worktag_DataField = value;
				this.RaisePropertyChanged("Default_Worktag_Data");
			}
		}

		[XmlElement(Order = 4)]
		public bool Replace_All_Allowed_Values
		{
			get
			{
				return this.replace_All_Allowed_ValuesField;
			}
			set
			{
				this.replace_All_Allowed_ValuesField = value;
				this.RaisePropertyChanged("Replace_All_Allowed_Values");
			}
		}

		[XmlIgnore]
		public bool Replace_All_Allowed_ValuesSpecified
		{
			get
			{
				return this.replace_All_Allowed_ValuesFieldSpecified;
			}
			set
			{
				this.replace_All_Allowed_ValuesFieldSpecified = value;
				this.RaisePropertyChanged("Replace_All_Allowed_ValuesSpecified");
			}
		}

		[XmlElement("Allowed_Worktag_Data", Order = 5)]
		public Allowed_Worktag_DataType[] Allowed_Worktag_Data
		{
			get
			{
				return this.allowed_Worktag_DataField;
			}
			set
			{
				this.allowed_Worktag_DataField = value;
				this.RaisePropertyChanged("Allowed_Worktag_Data");
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
