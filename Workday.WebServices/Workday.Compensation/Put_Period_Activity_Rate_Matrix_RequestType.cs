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
	public class Put_Period_Activity_Rate_Matrix_RequestType : INotifyPropertyChanged
	{
		private Period_Activity_Rate_MatrixObjectType period_Activity_Rate_Matrix_ReferenceField;

		private Period_Activity_Rate_Matrix_DataType period_Activity_Rate_Matrix_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Period_Activity_Rate_MatrixObjectType Period_Activity_Rate_Matrix_Reference
		{
			get
			{
				return this.period_Activity_Rate_Matrix_ReferenceField;
			}
			set
			{
				this.period_Activity_Rate_Matrix_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Rate_Matrix_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Period_Activity_Rate_Matrix_DataType Period_Activity_Rate_Matrix_Data
		{
			get
			{
				return this.period_Activity_Rate_Matrix_DataField;
			}
			set
			{
				this.period_Activity_Rate_Matrix_DataField = value;
				this.RaisePropertyChanged("Period_Activity_Rate_Matrix_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
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
