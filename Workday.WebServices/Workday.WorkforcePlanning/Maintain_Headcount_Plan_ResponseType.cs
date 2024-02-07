using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Maintain_Headcount_Plan_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType headcount_Plan_Version_Event_ReferenceField;

		private Headcount_Plan_VersionObjectType headcount_Plan_Version_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Headcount_Plan_Version_Event_Reference
		{
			get
			{
				return this.headcount_Plan_Version_Event_ReferenceField;
			}
			set
			{
				this.headcount_Plan_Version_Event_ReferenceField = value;
				this.RaisePropertyChanged("Headcount_Plan_Version_Event_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Headcount_Plan_VersionObjectType Headcount_Plan_Version_Reference
		{
			get
			{
				return this.headcount_Plan_Version_ReferenceField;
			}
			set
			{
				this.headcount_Plan_Version_ReferenceField = value;
				this.RaisePropertyChanged("Headcount_Plan_Version_Reference");
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
