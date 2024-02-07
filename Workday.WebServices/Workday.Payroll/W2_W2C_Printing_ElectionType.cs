using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "W-2_W-2C_Printing_ElectionType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class W2_W2C_Printing_ElectionType : INotifyPropertyChanged
	{
		private WorkerObjectType xMLNAME__Worker__ReferenceField;

		private W2_W2C_Printing_Election_DataType w2_W2C_Printing_Election_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType XMLNAME__Worker__Reference
		{
			get
			{
				return this.xMLNAME__Worker__ReferenceField;
			}
			set
			{
				this.xMLNAME__Worker__ReferenceField = value;
				this.RaisePropertyChanged("XMLNAME__Worker__Reference");
			}
		}

		[XmlElement("W-2_W-2C_Printing_Election_Data", Order = 1)]
		public W2_W2C_Printing_Election_DataType W2_W2C_Printing_Election_Data
		{
			get
			{
				return this.w2_W2C_Printing_Election_DataField;
			}
			set
			{
				this.w2_W2C_Printing_Election_DataField = value;
				this.RaisePropertyChanged("W2_W2C_Printing_Election_Data");
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
