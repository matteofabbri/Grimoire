using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Integration_Event_Request_CriteriaType : INotifyPropertyChanged
	{
		private Integration_SystemObjectType integration_System_ReferenceField;

		private Background_Process_Runtime_StatusObjectType[] integration_Event_Status_ReferenceField;

		private DateTime sent_AfterField;

		private bool sent_AfterFieldSpecified;

		private DateTime sent_BeforeField;

		private bool sent_BeforeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_SystemObjectType Integration_System_Reference
		{
			get
			{
				return this.integration_System_ReferenceField;
			}
			set
			{
				this.integration_System_ReferenceField = value;
				this.RaisePropertyChanged("Integration_System_Reference");
			}
		}

		[XmlElement("Integration_Event_Status_Reference", Order = 1)]
		public Background_Process_Runtime_StatusObjectType[] Integration_Event_Status_Reference
		{
			get
			{
				return this.integration_Event_Status_ReferenceField;
			}
			set
			{
				this.integration_Event_Status_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Event_Status_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime Sent_After
		{
			get
			{
				return this.sent_AfterField;
			}
			set
			{
				this.sent_AfterField = value;
				this.RaisePropertyChanged("Sent_After");
			}
		}

		[XmlIgnore]
		public bool Sent_AfterSpecified
		{
			get
			{
				return this.sent_AfterFieldSpecified;
			}
			set
			{
				this.sent_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Sent_AfterSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Sent_Before
		{
			get
			{
				return this.sent_BeforeField;
			}
			set
			{
				this.sent_BeforeField = value;
				this.RaisePropertyChanged("Sent_Before");
			}
		}

		[XmlIgnore]
		public bool Sent_BeforeSpecified
		{
			get
			{
				return this.sent_BeforeFieldSpecified;
			}
			set
			{
				this.sent_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Sent_BeforeSpecified");
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
