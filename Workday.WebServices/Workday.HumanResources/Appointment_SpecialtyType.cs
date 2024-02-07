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
	public class Appointment_SpecialtyType : INotifyPropertyChanged
	{
		private Appointment_SpecialtyObjectType appointment_Specialty_ReferenceField;

		private Appointment_Specialty_DataType[] appointment_Specialty_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Appointment_SpecialtyObjectType Appointment_Specialty_Reference
		{
			get
			{
				return this.appointment_Specialty_ReferenceField;
			}
			set
			{
				this.appointment_Specialty_ReferenceField = value;
				this.RaisePropertyChanged("Appointment_Specialty_Reference");
			}
		}

		[XmlElement("Appointment_Specialty_Data", Order = 1)]
		public Appointment_Specialty_DataType[] Appointment_Specialty_Data
		{
			get
			{
				return this.appointment_Specialty_DataField;
			}
			set
			{
				this.appointment_Specialty_DataField = value;
				this.RaisePropertyChanged("Appointment_Specialty_Data");
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
