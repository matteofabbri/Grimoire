using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Disability_Status_Information_DataType : INotifyPropertyChanged
	{
		private Disability_Status_ReferenceObjectType disability_Status_ReferenceField;

		private Disability_Status_Sub_DataType disability_Status_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Disability_Status_ReferenceObjectType Disability_Status_Reference
		{
			get
			{
				return this.disability_Status_ReferenceField;
			}
			set
			{
				this.disability_Status_ReferenceField = value;
				this.RaisePropertyChanged("Disability_Status_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Disability_Status_Sub_DataType Disability_Status_Data
		{
			get
			{
				return this.disability_Status_DataField;
			}
			set
			{
				this.disability_Status_DataField = value;
				this.RaisePropertyChanged("Disability_Status_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
