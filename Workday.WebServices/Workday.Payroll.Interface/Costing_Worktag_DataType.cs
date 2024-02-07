using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Costing_Worktag_DataType : INotifyPropertyChanged
	{
		private Tenanted_Payroll_WorktagObjectType tenanted_Payroll_Worktag_ReferenceField;

		private Worktag_DimensionObjectType worktag_Dimension_ReferenceField;

		private string worktag_CodeField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Tenanted_Payroll_WorktagObjectType Tenanted_Payroll_Worktag_Reference
		{
			get
			{
				return this.tenanted_Payroll_Worktag_ReferenceField;
			}
			set
			{
				this.tenanted_Payroll_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Tenanted_Payroll_Worktag_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Worktag_DimensionObjectType Worktag_Dimension_Reference
		{
			get
			{
				return this.worktag_Dimension_ReferenceField;
			}
			set
			{
				this.worktag_Dimension_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Dimension_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Worktag_Code
		{
			get
			{
				return this.worktag_CodeField;
			}
			set
			{
				this.worktag_CodeField = value;
				this.RaisePropertyChanged("Worktag_Code");
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
