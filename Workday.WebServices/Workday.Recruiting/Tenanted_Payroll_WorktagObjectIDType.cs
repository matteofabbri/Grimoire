using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Tenanted_Payroll_WorktagObjectIDType : INotifyPropertyChanged
	{
		private string typeField;

		private string parent_idField;

		private string parent_typeField;

		private string valueField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("type");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string parent_id
		{
			get
			{
				return this.parent_idField;
			}
			set
			{
				this.parent_idField = value;
				this.RaisePropertyChanged("parent_id");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string parent_type
		{
			get
			{
				return this.parent_typeField;
			}
			set
			{
				this.parent_typeField = value;
				this.RaisePropertyChanged("parent_type");
			}
		}

		[XmlText]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
				this.RaisePropertyChanged("Value");
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
