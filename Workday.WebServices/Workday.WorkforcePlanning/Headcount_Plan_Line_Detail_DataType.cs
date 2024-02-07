using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Headcount_Plan_Line_Detail_DataType : INotifyPropertyChanged
	{
		private string commentField;

		private Accounting_Worktag_and_Aggregation_DimensionObjectType[] worktags_ReferenceField;

		private Headcount_Plan_Period_DataType[] headcount_Plan_Period_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
			}
		}

		[XmlElement("Worktags_Reference", Order = 1)]
		public Accounting_Worktag_and_Aggregation_DimensionObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement("Headcount_Plan_Period_Data", Order = 2)]
		public Headcount_Plan_Period_DataType[] Headcount_Plan_Period_Data
		{
			get
			{
				return this.headcount_Plan_Period_DataField;
			}
			set
			{
				this.headcount_Plan_Period_DataField = value;
				this.RaisePropertyChanged("Headcount_Plan_Period_Data");
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
