using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Manage_Awards_and_Activities_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType worker_Award_Event_ReferenceField;

		private AwardObjectType[] award_and_Activity_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Worker_Award_Event_Reference
		{
			get
			{
				return this.worker_Award_Event_ReferenceField;
			}
			set
			{
				this.worker_Award_Event_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Award_Event_Reference");
			}
		}

		[XmlElement("Award_and_Activity_Reference", Order = 1)]
		public AwardObjectType[] Award_and_Activity_Reference
		{
			get
			{
				return this.award_and_Activity_ReferenceField;
			}
			set
			{
				this.award_and_Activity_ReferenceField = value;
				this.RaisePropertyChanged("Award_and_Activity_Reference");
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
