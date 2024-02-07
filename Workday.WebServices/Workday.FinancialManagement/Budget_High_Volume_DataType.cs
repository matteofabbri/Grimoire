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
	public class Budget_High_Volume_DataType : INotifyPropertyChanged
	{
		private bool submitField;

		private bool submitFieldSpecified;

		private Budget_StructureObjectType budget_Structure_ReferenceField;

		private Budget_SourceObjectType budget_Name_ReferenceField;

		private string budget_MemoField;

		private Budget_Lines_High_Volume_DataType[] budget_Lines_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Submit
		{
			get
			{
				return this.submitField;
			}
			set
			{
				this.submitField = value;
				this.RaisePropertyChanged("Submit");
			}
		}

		[XmlIgnore]
		public bool SubmitSpecified
		{
			get
			{
				return this.submitFieldSpecified;
			}
			set
			{
				this.submitFieldSpecified = value;
				this.RaisePropertyChanged("SubmitSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Budget_StructureObjectType Budget_Structure_Reference
		{
			get
			{
				return this.budget_Structure_ReferenceField;
			}
			set
			{
				this.budget_Structure_ReferenceField = value;
				this.RaisePropertyChanged("Budget_Structure_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Budget_SourceObjectType Budget_Name_Reference
		{
			get
			{
				return this.budget_Name_ReferenceField;
			}
			set
			{
				this.budget_Name_ReferenceField = value;
				this.RaisePropertyChanged("Budget_Name_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Budget_Memo
		{
			get
			{
				return this.budget_MemoField;
			}
			set
			{
				this.budget_MemoField = value;
				this.RaisePropertyChanged("Budget_Memo");
			}
		}

		[XmlElement("Budget_Lines_Data", Order = 4)]
		public Budget_Lines_High_Volume_DataType[] Budget_Lines_Data
		{
			get
			{
				return this.budget_Lines_DataField;
			}
			set
			{
				this.budget_Lines_DataField = value;
				this.RaisePropertyChanged("Budget_Lines_Data");
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
