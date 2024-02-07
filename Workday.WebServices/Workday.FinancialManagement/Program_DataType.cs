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
	public class Program_DataType : INotifyPropertyChanged
	{
		private string program_IDField;

		private string program_NameField;

		private bool include_Program_ID_in_NameField;

		private bool include_Program_ID_in_NameFieldSpecified;

		private bool program_is_InactiveField;

		private bool program_is_InactiveFieldSpecified;

		private Related_Worktags_by_Worktag_Type_DataType[] related_Worktags_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Program_ID
		{
			get
			{
				return this.program_IDField;
			}
			set
			{
				this.program_IDField = value;
				this.RaisePropertyChanged("Program_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Program_Name
		{
			get
			{
				return this.program_NameField;
			}
			set
			{
				this.program_NameField = value;
				this.RaisePropertyChanged("Program_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Program_ID_in_Name
		{
			get
			{
				return this.include_Program_ID_in_NameField;
			}
			set
			{
				this.include_Program_ID_in_NameField = value;
				this.RaisePropertyChanged("Include_Program_ID_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Program_ID_in_NameSpecified
		{
			get
			{
				return this.include_Program_ID_in_NameFieldSpecified;
			}
			set
			{
				this.include_Program_ID_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Program_ID_in_NameSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Program_is_Inactive
		{
			get
			{
				return this.program_is_InactiveField;
			}
			set
			{
				this.program_is_InactiveField = value;
				this.RaisePropertyChanged("Program_is_Inactive");
			}
		}

		[XmlIgnore]
		public bool Program_is_InactiveSpecified
		{
			get
			{
				return this.program_is_InactiveFieldSpecified;
			}
			set
			{
				this.program_is_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Program_is_InactiveSpecified");
			}
		}

		[XmlArray(Order = 4), XmlArrayItem("Related_Worktags_by_Type_Data", IsNullable = false)]
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
