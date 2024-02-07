using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Academic_ContactType : INotifyPropertyChanged
	{
		private Academic_ContactObjectType academic_Contact_ReferenceField;

		private Academic_Contact_DataType academic_Contact_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_ContactObjectType Academic_Contact_Reference
		{
			get
			{
				return this.academic_Contact_ReferenceField;
			}
			set
			{
				this.academic_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Contact_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Academic_Contact_DataType Academic_Contact_Data
		{
			get
			{
				return this.academic_Contact_DataField;
			}
			set
			{
				this.academic_Contact_DataField = value;
				this.RaisePropertyChanged("Academic_Contact_Data");
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
