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
	public class Location_Request_ReferencesType : INotifyPropertyChanged
	{
		private LocationObjectType[] location_ReferenceField;

		private bool skip_Non_Existing_InstancesField;

		private bool skip_Non_Existing_InstancesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Location_Reference", Order = 0)]
		public LocationObjectType[] Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
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
