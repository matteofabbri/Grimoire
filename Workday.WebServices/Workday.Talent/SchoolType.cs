using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class SchoolType : INotifyPropertyChanged
	{
		private SchoolObjectType school_ReferenceField;

		private School_DataType school_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public SchoolObjectType School_Reference
		{
			get
			{
				return this.school_ReferenceField;
			}
			set
			{
				this.school_ReferenceField = value;
				this.RaisePropertyChanged("School_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public School_DataType School_Data
		{
			get
			{
				return this.school_DataField;
			}
			set
			{
				this.school_DataField = value;
				this.RaisePropertyChanged("School_Data");
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
