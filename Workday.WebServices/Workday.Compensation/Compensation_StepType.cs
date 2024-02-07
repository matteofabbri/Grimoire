using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensation_StepType : INotifyPropertyChanged
	{
		private Compensation_StepObjectType compensation_Step_ReferenceField;

		private Compensation_Step_DataType compensation_Step_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_StepObjectType Compensation_Step_Reference
		{
			get
			{
				return this.compensation_Step_ReferenceField;
			}
			set
			{
				this.compensation_Step_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Step_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Compensation_Step_DataType Compensation_Step_Data
		{
			get
			{
				return this.compensation_Step_DataField;
			}
			set
			{
				this.compensation_Step_DataField = value;
				this.RaisePropertyChanged("Compensation_Step_Data");
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
