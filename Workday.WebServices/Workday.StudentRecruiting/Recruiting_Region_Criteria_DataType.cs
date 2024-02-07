using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Recruiting_Region_Criteria_DataType : INotifyPropertyChanged
	{
		private Recruiting_Region_CriteriaObjectType recruiting_Region_Criteria_ReferenceField;

		private Has_Academic_Curricular_Division_DataType[] has_Academic_Unit_DataField;

		private Recruiting_Region_Geographic_Criteria_DataType[] recruiting_Region_Geographic_Criteria_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Recruiting_Region_CriteriaObjectType Recruiting_Region_Criteria_Reference
		{
			get
			{
				return this.recruiting_Region_Criteria_ReferenceField;
			}
			set
			{
				this.recruiting_Region_Criteria_ReferenceField = value;
				this.RaisePropertyChanged("Recruiting_Region_Criteria_Reference");
			}
		}

		[XmlElement("Has_Academic_Unit_Data", Order = 1)]
		public Has_Academic_Curricular_Division_DataType[] Has_Academic_Unit_Data
		{
			get
			{
				return this.has_Academic_Unit_DataField;
			}
			set
			{
				this.has_Academic_Unit_DataField = value;
				this.RaisePropertyChanged("Has_Academic_Unit_Data");
			}
		}

		[XmlElement("Recruiting_Region_Geographic_Criteria_Data", Order = 2)]
		public Recruiting_Region_Geographic_Criteria_DataType[] Recruiting_Region_Geographic_Criteria_Data
		{
			get
			{
				return this.recruiting_Region_Geographic_Criteria_DataField;
			}
			set
			{
				this.recruiting_Region_Geographic_Criteria_DataField = value;
				this.RaisePropertyChanged("Recruiting_Region_Geographic_Criteria_Data");
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
