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
	public class Headcount_Plan_High_Volume_DataType : INotifyPropertyChanged
	{
		private bool submitField;

		private bool submitFieldSpecified;

		private Budget_StructureObjectType headcount_Plan_Structure_ReferenceField;

		private Budget_SourceObjectType headcount_Plan_Name_ReferenceField;

		private string headcount_Plan_MemoField;

		private Headcount_Plan_Lines_High_Volume_DataType[] headcount_Plan_Lines_DataField;

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
		public Budget_StructureObjectType Headcount_Plan_Structure_Reference
		{
			get
			{
				return this.headcount_Plan_Structure_ReferenceField;
			}
			set
			{
				this.headcount_Plan_Structure_ReferenceField = value;
				this.RaisePropertyChanged("Headcount_Plan_Structure_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Budget_SourceObjectType Headcount_Plan_Name_Reference
		{
			get
			{
				return this.headcount_Plan_Name_ReferenceField;
			}
			set
			{
				this.headcount_Plan_Name_ReferenceField = value;
				this.RaisePropertyChanged("Headcount_Plan_Name_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Headcount_Plan_Memo
		{
			get
			{
				return this.headcount_Plan_MemoField;
			}
			set
			{
				this.headcount_Plan_MemoField = value;
				this.RaisePropertyChanged("Headcount_Plan_Memo");
			}
		}

		[XmlElement("Headcount_Plan_Lines_Data", Order = 4)]
		public Headcount_Plan_Lines_High_Volume_DataType[] Headcount_Plan_Lines_Data
		{
			get
			{
				return this.headcount_Plan_Lines_DataField;
			}
			set
			{
				this.headcount_Plan_Lines_DataField = value;
				this.RaisePropertyChanged("Headcount_Plan_Lines_Data");
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
