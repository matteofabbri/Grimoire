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
	public class Headcount_Plan_Line_Get_DataType : INotifyPropertyChanged
	{
		private Headcount_Plan_LineObjectType headcount_Plan_Line_ReferenceField;

		private string commentField;

		private HR_WorktagObjectType[] worktags_ReferenceField;

		private Headcount_Plan_Period_Get_DataType[] headcount_Plan_Period_Get_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Headcount_Plan_LineObjectType Headcount_Plan_Line_Reference
		{
			get
			{
				return this.headcount_Plan_Line_ReferenceField;
			}
			set
			{
				this.headcount_Plan_Line_ReferenceField = value;
				this.RaisePropertyChanged("Headcount_Plan_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement("Worktags_Reference", Order = 2)]
		public HR_WorktagObjectType[] Worktags_Reference
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

		[XmlElement("Headcount_Plan_Period_Get_Data", Order = 3)]
		public Headcount_Plan_Period_Get_DataType[] Headcount_Plan_Period_Get_Data
		{
			get
			{
				return this.headcount_Plan_Period_Get_DataField;
			}
			set
			{
				this.headcount_Plan_Period_Get_DataField = value;
				this.RaisePropertyChanged("Headcount_Plan_Period_Get_Data");
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
