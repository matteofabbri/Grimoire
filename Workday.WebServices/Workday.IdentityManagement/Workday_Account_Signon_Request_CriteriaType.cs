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
	public class Workday_Account_Signon_Request_CriteriaType : INotifyPropertyChanged
	{
		private DateTime from_DateTimeField;

		private bool from_DateTimeFieldSpecified;

		private DateTime to_DateTimeField;

		private bool to_DateTimeFieldSpecified;

		private object[] itemsField;

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

		[XmlElement("User_Name", typeof(string), Order = 2), XmlElement("Workday_Account_Reference", typeof(System_AccountObjectType), Order = 2)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
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
