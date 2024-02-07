using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Give_Feedback_Business_Process_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType from_Worker_ReferenceField;

		private WorkerObjectType to_Worker_ReferenceField;

		private Feedback_BadgeObjectType badge_ReferenceField;

		private string commentField;

		private bool show_NameField;

		private bool show_NameFieldSpecified;

		private bool confidentialField;

		private bool confidentialFieldSpecified;

		private bool privateField;

		private bool privateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType From_Worker_Reference
		{
			get
			{
				return this.from_Worker_ReferenceField;
			}
			set
			{
				this.from_Worker_ReferenceField = value;
				this.RaisePropertyChanged("From_Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType To_Worker_Reference
		{
			get
			{
				return this.to_Worker_ReferenceField;
			}
			set
			{
				this.to_Worker_ReferenceField = value;
				this.RaisePropertyChanged("To_Worker_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Feedback_BadgeObjectType Badge_Reference
		{
			get
			{
				return this.badge_ReferenceField;
			}
			set
			{
				this.badge_ReferenceField = value;
				this.RaisePropertyChanged("Badge_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
			}
		}

		[XmlElement(Order = 4)]
		public bool Show_Name
		{
			get
			{
				return this.show_NameField;
			}
			set
			{
				this.show_NameField = value;
				this.RaisePropertyChanged("Show_Name");
			}
		}

		[XmlIgnore]
		public bool Show_NameSpecified
		{
			get
			{
				return this.show_NameFieldSpecified;
			}
			set
			{
				this.show_NameFieldSpecified = value;
				this.RaisePropertyChanged("Show_NameSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Confidential
		{
			get
			{
				return this.confidentialField;
			}
			set
			{
				this.confidentialField = value;
				this.RaisePropertyChanged("Confidential");
			}
		}

		[XmlIgnore]
		public bool ConfidentialSpecified
		{
			get
			{
				return this.confidentialFieldSpecified;
			}
			set
			{
				this.confidentialFieldSpecified = value;
				this.RaisePropertyChanged("ConfidentialSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Private
		{
			get
			{
				return this.privateField;
			}
			set
			{
				this.privateField = value;
				this.RaisePropertyChanged("Private");
			}
		}

		[XmlIgnore]
		public bool PrivateSpecified
		{
			get
			{
				return this.privateFieldSpecified;
			}
			set
			{
				this.privateFieldSpecified = value;
				this.RaisePropertyChanged("PrivateSpecified");
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
