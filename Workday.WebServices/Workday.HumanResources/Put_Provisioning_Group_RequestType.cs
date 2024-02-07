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
	public class Put_Provisioning_Group_RequestType : INotifyPropertyChanged
	{
		private Provisioning_GroupObjectType provisioning_Group_ReferenceField;

		private Provisioning_Group_DataType provisioning_Group_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Provisioning_GroupObjectType Provisioning_Group_Reference
		{
			get
			{
				return this.provisioning_Group_ReferenceField;
			}
			set
			{
				this.provisioning_Group_ReferenceField = value;
				this.RaisePropertyChanged("Provisioning_Group_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Provisioning_Group_DataType Provisioning_Group_Data
		{
			get
			{
				return this.provisioning_Group_DataField;
			}
			set
			{
				this.provisioning_Group_DataField = value;
				this.RaisePropertyChanged("Provisioning_Group_Data");
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
