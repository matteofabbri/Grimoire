using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Academic_RankObjectType : INotifyPropertyChanged
	{
		private Academic_RankObjectIDType[] idField;

		private string descriptorField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("ID", Order = 0)]
		public Academic_RankObjectIDType[] ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Descriptor
		{
			get
			{
				return this.descriptorField;
			}
			set
			{
				this.descriptorField = value;
				this.RaisePropertyChanged("Descriptor");
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