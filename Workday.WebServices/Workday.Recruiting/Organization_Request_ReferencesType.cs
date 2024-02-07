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
	public class Organization_Request_ReferencesType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] organization_ReferenceField;

		private bool skip_Non_Existing_InstancesField;

		private bool skip_Non_Existing_InstancesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Organization_Reference", Order = 0)]
		public OrganizationObjectType[] Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Skip_Non_Existing_Instances
		{
			get
			{
				return this.skip_Non_Existing_InstancesField;
			}
			set
			{
				this.skip_Non_Existing_InstancesField = value;
				this.RaisePropertyChanged("Skip_Non_Existing_Instances");
			}
		}

		[XmlIgnore]
		public bool Skip_Non_Existing_InstancesSpecified
		{
			get
			{
				return this.skip_Non_Existing_InstancesFieldSpecified;
			}
			set
			{
				this.skip_Non_Existing_InstancesFieldSpecified = value;
				this.RaisePropertyChanged("Skip_Non_Existing_InstancesSpecified");
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
