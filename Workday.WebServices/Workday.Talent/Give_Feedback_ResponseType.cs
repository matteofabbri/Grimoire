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
	public class Give_Feedback_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType give_Feedback_Event_ReferenceField;

		private Unique_IdentifierObjectType feedback_Given_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Give_Feedback_Event_Reference
		{
			get
			{
				return this.give_Feedback_Event_ReferenceField;
			}
			set
			{
				this.give_Feedback_Event_ReferenceField = value;
				this.RaisePropertyChanged("Give_Feedback_Event_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Unique_IdentifierObjectType Feedback_Given_Reference
		{
			get
			{
				return this.feedback_Given_ReferenceField;
			}
			set
			{
				this.feedback_Given_ReferenceField = value;
				this.RaisePropertyChanged("Feedback_Given_Reference");
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
