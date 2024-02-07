using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Personal_Preferences_DataType : INotifyPropertyChanged
	{
		private bool receive_Email_NotificationsField;

		private bool receive_Email_NotificationsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Receive_Email_Notifications
		{
			get
			{
				return this.receive_Email_NotificationsField;
			}
			set
			{
				this.receive_Email_NotificationsField = value;
				this.RaisePropertyChanged("Receive_Email_Notifications");
			}
		}

		[XmlIgnore]
		public bool Receive_Email_NotificationsSpecified
		{
			get
			{
				return this.receive_Email_NotificationsFieldSpecified;
			}
			set
			{
				this.receive_Email_NotificationsFieldSpecified = value;
				this.RaisePropertyChanged("Receive_Email_NotificationsSpecified");
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
