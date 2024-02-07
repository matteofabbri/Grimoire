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
	public class Recalculate_Bank_Statement_Balance_ResponseType : INotifyPropertyChanged
	{
		private Recalculated_Bank_Statement_DataType[] recalculated_Bank_StatementField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Recalculated_Bank_Statement", Order = 0)]
		public Recalculated_Bank_Statement_DataType[] Recalculated_Bank_Statement
		{
			get
			{
				return this.recalculated_Bank_StatementField;
			}
			set
			{
				this.recalculated_Bank_StatementField = value;
				this.RaisePropertyChanged("Recalculated_Bank_Statement");
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
