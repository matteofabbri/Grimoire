using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Request_One-Time_Payment_ResponseType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Request_OneTime_Payment_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType oneTime_Payment_Event_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("One-Time_Payment_Event_Reference", Order = 0)]
		public Unique_IdentifierObjectType OneTime_Payment_Event_Reference
		{
			get
			{
				return this.oneTime_Payment_Event_ReferenceField;
			}
			set
			{
				this.oneTime_Payment_Event_ReferenceField = value;
				this.RaisePropertyChanged("OneTime_Payment_Event_Reference");
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
