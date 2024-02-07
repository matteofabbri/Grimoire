using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Background_Check_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private Background_Check_Overall_Status_DataType background_Check_Status_DataField;

		private Package_Reference_DataType package_Reference_DataField;

		private Test_Reference_DataType[] test_Reference_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Event_Reference", typeof(Background_Check_EventObjectType), Order = 0), XmlElement("Recipient_Reference", typeof(RoleObjectType), Order = 0)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 1)]
		public Background_Check_Overall_Status_DataType Background_Check_Status_Data
		{
			get
			{
				return this.background_Check_Status_DataField;
			}
			set
			{
				this.background_Check_Status_DataField = value;
				this.RaisePropertyChanged("Background_Check_Status_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Package_Reference_DataType Package_Reference_Data
		{
			get
			{
				return this.package_Reference_DataField;
			}
			set
			{
				this.package_Reference_DataField = value;
				this.RaisePropertyChanged("Package_Reference_Data");
			}
		}

		[XmlElement("Test_Reference_Data", Order = 3)]
		public Test_Reference_DataType[] Test_Reference_Data
		{
			get
			{
				return this.test_Reference_DataField;
			}
			set
			{
				this.test_Reference_DataField = value;
				this.RaisePropertyChanged("Test_Reference_Data");
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
