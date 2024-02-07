using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Education_Test_Section_Non-Numeric_Value__Metadata_ObjectType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Education_Test_Section_NonNumeric_Value__Metadata_ObjectType : INotifyPropertyChanged
	{
		private Education_Test_Section_NonNumeric_Value__Metadata_ObjectIDType[] idField;

		private string descriptorField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("ID", Order = 0)]
		public Education_Test_Section_NonNumeric_Value__Metadata_ObjectIDType[] ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Descriptor
		{
			get
			{
				return this.descriptorField;
			}
			set
			{
				this.descriptorField = value;
				this.RaisePropertyChanged("Descriptor");
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
