using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Has_Schedulable_Defaults_DataType : INotifyPropertyChanged
	{
		private LocationObjectType[] location_ReferenceField;

		private Academic_Period_TypeObjectType[] academic_Periods_Offered_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Location_Reference", Order = 0)]
		public LocationObjectType[] Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement("Academic_Periods_Offered_Type_Reference", Order = 1)]
		public Academic_Period_TypeObjectType[] Academic_Periods_Offered_Type_Reference
		{
			get
			{
				return this.academic_Periods_Offered_Type_ReferenceField;
			}
			set
			{
				this.academic_Periods_Offered_Type_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Periods_Offered_Type_Reference");
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
