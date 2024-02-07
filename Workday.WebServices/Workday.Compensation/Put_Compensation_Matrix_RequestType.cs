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
	public class Put_Compensation_Matrix_RequestType : INotifyPropertyChanged
	{
		private Compensation_MatrixObjectType compensation_Matrix_ReferenceField;

		private Compensation_Matrix_DataType compensation_Matrix_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_MatrixObjectType Compensation_Matrix_Reference
		{
			get
			{
				return this.compensation_Matrix_ReferenceField;
			}
			set
			{
				this.compensation_Matrix_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Matrix_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Compensation_Matrix_DataType Compensation_Matrix_Data
		{
			get
			{
				return this.compensation_Matrix_DataField;
			}
			set
			{
				this.compensation_Matrix_DataField = value;
				this.RaisePropertyChanged("Compensation_Matrix_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
