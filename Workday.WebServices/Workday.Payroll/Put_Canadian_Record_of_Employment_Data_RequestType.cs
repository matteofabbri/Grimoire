using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Canadian_Record_of_Employment_Data_RequestType : INotifyPropertyChanged
	{
		private Canadian_Record_of_Employment_Data_DataType[] canadian_Record_of_Employment_Data_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Canadian_Record_of_Employment_Data_Data", Order = 0)]
		public Canadian_Record_of_Employment_Data_DataType[] Canadian_Record_of_Employment_Data_Data
		{
			get
			{
				return this.canadian_Record_of_Employment_Data_DataField;
			}
			set
			{
				this.canadian_Record_of_Employment_Data_DataField = value;
				this.RaisePropertyChanged("Canadian_Record_of_Employment_Data_Data");
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
