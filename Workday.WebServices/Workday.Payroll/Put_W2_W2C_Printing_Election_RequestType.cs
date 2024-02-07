using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Put_W-2_W-2C_Printing_Election_RequestType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_W2_W2C_Printing_Election_RequestType : INotifyPropertyChanged
	{
		private W2_W2C_Printing_Election_Request_DataType[] w2_W2C_Printing_Election_Request_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("W-2_W-2C_Printing_Election_Request_Data", Order = 0)]
		public W2_W2C_Printing_Election_Request_DataType[] W2_W2C_Printing_Election_Request_Data
		{
			get
			{
				return this.w2_W2C_Printing_Election_Request_DataField;
			}
			set
			{
				this.w2_W2C_Printing_Election_Request_DataField = value;
				this.RaisePropertyChanged("W2_W2C_Printing_Election_Request_Data");
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
