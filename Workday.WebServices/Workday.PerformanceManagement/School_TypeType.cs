using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class School_TypeType : INotifyPropertyChanged
	{
		private School_TypeObjectType school_Type_ReferenceField;

		private School_Type_DataType school_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public School_TypeObjectType School_Type_Reference
		{
			get
			{
				return this.school_Type_ReferenceField;
			}
			set
			{
				this.school_Type_ReferenceField = value;
				this.RaisePropertyChanged("School_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public School_Type_DataType School_Type_Data
		{
			get
			{
				return this.school_Type_DataField;
			}
			set
			{
				this.school_Type_DataField = value;
				this.RaisePropertyChanged("School_Type_Data");
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
