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
	public class Work_Experience_Skill_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string descriptionField;

		private decimal talent_Card_Sort_OrderField;

		private bool talent_Card_Sort_OrderFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Work_Experience_Rating_DataType[] work_Experience_Rating_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Talent_Card_Sort_Order
		{
			get
			{
				return this.talent_Card_Sort_OrderField;
			}
			set
			{
				this.talent_Card_Sort_OrderField = value;
				this.RaisePropertyChanged("Talent_Card_Sort_Order");
			}
		}

		[XmlIgnore]
		public bool Talent_Card_Sort_OrderSpecified
		{
			get
			{
				return this.talent_Card_Sort_OrderFieldSpecified;
			}
			set
			{
				this.talent_Card_Sort_OrderFieldSpecified = value;
				this.RaisePropertyChanged("Talent_Card_Sort_OrderSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement("Work_Experience_Rating_Data", Order = 4)]
		public Work_Experience_Rating_DataType[] Work_Experience_Rating_Data
		{
			get
			{
				return this.work_Experience_Rating_DataField;
			}
			set
			{
				this.work_Experience_Rating_DataField = value;
				this.RaisePropertyChanged("Work_Experience_Rating_Data");
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
