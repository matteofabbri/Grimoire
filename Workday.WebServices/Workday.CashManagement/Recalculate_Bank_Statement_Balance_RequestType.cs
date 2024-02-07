using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Recalculate_Bank_Statement_Balance_RequestType : INotifyPropertyChanged
	{
		private Bank_Statement_Criteria_DataType[] recalculate_Bank_Statement_Balance_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("Bank_Statement_Criteria_Data", IsNullable = false)]
		public Bank_Statement_Criteria_DataType[] Recalculate_Bank_Statement_Balance_Data
		{
			get
			{
				return this.recalculate_Bank_Statement_Balance_DataField;
			}
			set
			{
				this.recalculate_Bank_Statement_Balance_DataField = value;
				this.RaisePropertyChanged("Recalculate_Bank_Statement_Balance_Data");
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
