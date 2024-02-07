using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payslip_Run_Category_DataType : INotifyPropertyChanged
	{
		private Run_CategoryObjectType run_Category_ReferenceField;

		private bool regular_Run_CategoryField;

		private bool regular_Run_CategoryFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Run_CategoryObjectType Run_Category_Reference
		{
			get
			{
				return this.run_Category_ReferenceField;
			}
			set
			{
				this.run_Category_ReferenceField = value;
				this.RaisePropertyChanged("Run_Category_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Regular_Run_Category
		{
			get
			{
				return this.regular_Run_CategoryField;
			}
			set
			{
				this.regular_Run_CategoryField = value;
				this.RaisePropertyChanged("Regular_Run_Category");
			}
		}

		[XmlIgnore]
		public bool Regular_Run_CategorySpecified
		{
			get
			{
				return this.regular_Run_CategoryFieldSpecified;
			}
			set
			{
				this.regular_Run_CategoryFieldSpecified = value;
				this.RaisePropertyChanged("Regular_Run_CategorySpecified");
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
