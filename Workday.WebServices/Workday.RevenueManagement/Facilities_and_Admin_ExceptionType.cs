using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Facilities_and_Admin_ExceptionType : INotifyPropertyChanged
	{
		private Facilities_and_Admin_ExceptionObjectType facilities_and_Administration_Exception_ReferenceField;

		private Facilities_and_Admin_Exception_DataType[] facilities_and_Administration_Exception_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Facilities_and_Admin_ExceptionObjectType Facilities_and_Administration_Exception_Reference
		{
			get
			{
				return this.facilities_and_Administration_Exception_ReferenceField;
			}
			set
			{
				this.facilities_and_Administration_Exception_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Exception_Reference");
			}
		}

		[XmlElement("Facilities_and_Administration_Exception_Data", Order = 1)]
		public Facilities_and_Admin_Exception_DataType[] Facilities_and_Administration_Exception_Data
		{
			get
			{
				return this.facilities_and_Administration_Exception_DataField;
			}
			set
			{
				this.facilities_and_Administration_Exception_DataField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Exception_Data");
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
