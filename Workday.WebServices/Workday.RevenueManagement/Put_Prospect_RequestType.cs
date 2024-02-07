using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Prospect_RequestType : INotifyPropertyChanged
	{
		private ProspectObjectType prospect_ReferenceField;

		private Prospect_DataType prospect_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public ProspectObjectType Prospect_Reference
		{
			get
			{
				return this.prospect_ReferenceField;
			}
			set
			{
				this.prospect_ReferenceField = value;
				this.RaisePropertyChanged("Prospect_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Prospect_DataType Prospect_Data
		{
			get
			{
				return this.prospect_DataField;
			}
			set
			{
				this.prospect_DataField = value;
				this.RaisePropertyChanged("Prospect_Data");
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
