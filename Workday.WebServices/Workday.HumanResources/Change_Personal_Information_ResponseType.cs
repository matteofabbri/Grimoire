using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Change_Personal_Information_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType personal_Information_Change_Event_ReferenceField;

		private Change_Personal_Information_DataType personal_Information_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Personal_Information_Change_Event_Reference
		{
			get
			{
				return this.personal_Information_Change_Event_ReferenceField;
			}
			set
			{
				this.personal_Information_Change_Event_ReferenceField = value;
				this.RaisePropertyChanged("Personal_Information_Change_Event_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Change_Personal_Information_DataType Personal_Information_Data
		{
			get
			{
				return this.personal_Information_DataField;
			}
			set
			{
				this.personal_Information_DataField = value;
				this.RaisePropertyChanged("Personal_Information_Data");
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
