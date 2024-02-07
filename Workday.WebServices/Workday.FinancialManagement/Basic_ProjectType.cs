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
	public class Basic_ProjectType : INotifyPropertyChanged
	{
		private ProjectObjectType basic_Project_ReferenceField;

		private Basic_Project_DataType basic_Project_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public ProjectObjectType Basic_Project_Reference
		{
			get
			{
				return this.basic_Project_ReferenceField;
			}
			set
			{
				this.basic_Project_ReferenceField = value;
				this.RaisePropertyChanged("Basic_Project_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Basic_Project_DataType Basic_Project_Data
		{
			get
			{
				return this.basic_Project_DataField;
			}
			set
			{
				this.basic_Project_DataField = value;
				this.RaisePropertyChanged("Basic_Project_Data");
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
