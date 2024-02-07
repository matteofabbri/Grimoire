using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll.Fra
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class DSN_BlockType : INotifyPropertyChanged
	{
		private DSN_Rubric_DetailType[] dSN_Rubric_DetailField;

		private DSN_BlockType[] dSN_BlockField;

		private string context_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("DSN_Rubric_Detail", Order = 0)]
		public DSN_Rubric_DetailType[] DSN_Rubric_Detail
		{
			get
			{
				return this.dSN_Rubric_DetailField;
			}
			set
			{
				this.dSN_Rubric_DetailField = value;
				this.RaisePropertyChanged("DSN_Rubric_Detail");
			}
		}

		[XmlElement("DSN_Block", Order = 1)]
		public DSN_BlockType[] DSN_Block
		{
			get
			{
				return this.dSN_BlockField;
			}
			set
			{
				this.dSN_BlockField = value;
				this.RaisePropertyChanged("DSN_Block");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Context_ID
		{
			get
			{
				return this.context_IDField;
			}
			set
			{
				this.context_IDField = value;
				this.RaisePropertyChanged("Context_ID");
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
