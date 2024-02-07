using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.IdentityManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Unidentified_Signon_Request_CriteriaType : INotifyPropertyChanged
	{
		private DateTime from_DateTimeField;

		private bool from_DateTimeFieldSpecified;

		private DateTime to_DateTimeField;

		private bool to_DateTimeFieldSpecified;

		private string user_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime From_DateTime
		{
			get
			{
				return this.from_DateTimeField;
			}
			set
			{
				this.from_DateTimeField = value;
				this.RaisePropertyChanged("From_DateTime");
			}
		}

		[XmlIgnore]
		public bool From_DateTimeSpecified
		{
			get
			{
				return this.from_DateTimeFieldSpecified;
			}
			set
			{
				this.from_DateTimeFieldSpecified = value;
				this.RaisePropertyChanged("From_DateTimeSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime To_DateTime
		{
			get
			{
				return this.to_DateTimeField;
			}
			set
			{
				this.to_DateTimeField = value;
				this.RaisePropertyChanged("To_DateTime");
			}
		}

		[XmlIgnore]
		public bool To_DateTimeSpecified
		{
			get
			{
				return this.to_DateTimeFieldSpecified;
			}
			set
			{
				this.to_DateTimeFieldSpecified = value;
				this.RaisePropertyChanged("To_DateTimeSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string User_Name
		{
			get
			{
				return this.user_NameField;
			}
			set
			{
				this.user_NameField = value;
				this.RaisePropertyChanged("User_Name");
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
