using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Create_Benefit_Life_Event_DataType : INotifyPropertyChanged
	{
		private Benefit_Life_Event_TypeObjectType life_Event_Type_ReferenceField;

		private DateTime life_Event_DateField;

		private bool life_Event_DateFieldSpecified;

		private DateTime submit_Elections_ByField;

		private bool submit_Elections_ByFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Benefit_Life_Event_TypeObjectType Life_Event_Type_Reference
		{
			get
			{
				return this.life_Event_Type_ReferenceField;
			}
			set
			{
				this.life_Event_Type_ReferenceField = value;
				this.RaisePropertyChanged("Life_Event_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Life_Event_Date
		{
			get
			{
				return this.life_Event_DateField;
			}
			set
			{
				this.life_Event_DateField = value;
				this.RaisePropertyChanged("Life_Event_Date");
			}
		}

		[XmlIgnore]
		public bool Life_Event_DateSpecified
		{
			get
			{
				return this.life_Event_DateFieldSpecified;
			}
			set
			{
				this.life_Event_DateFieldSpecified = value;
				this.RaisePropertyChanged("Life_Event_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Submit_Elections_By
		{
			get
			{
				return this.submit_Elections_ByField;
			}
			set
			{
				this.submit_Elections_ByField = value;
				this.RaisePropertyChanged("Submit_Elections_By");
			}
		}

		[XmlIgnore]
		public bool Submit_Elections_BySpecified
		{
			get
			{
				return this.submit_Elections_ByFieldSpecified;
			}
			set
			{
				this.submit_Elections_ByFieldSpecified = value;
				this.RaisePropertyChanged("Submit_Elections_BySpecified");
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
