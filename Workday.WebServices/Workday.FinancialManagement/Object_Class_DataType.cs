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
	public class Object_Class_DataType : INotifyPropertyChanged
	{
		private string object_Class_CodeField;

		private string object_Class_DescriptionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Object_Class_Code
		{
			get
			{
				return this.object_Class_CodeField;
			}
			set
			{
				this.object_Class_CodeField = value;
				this.RaisePropertyChanged("Object_Class_Code");
			}
		}

		[XmlElement(Order = 1)]
		public string Object_Class_Description
		{
			get
			{
				return this.object_Class_DescriptionField;
			}
			set
			{
				this.object_Class_DescriptionField = value;
				this.RaisePropertyChanged("Object_Class_Description");
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
