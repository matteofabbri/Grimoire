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
	public class Collective_Agreement_Factor_Options_DataType : INotifyPropertyChanged
	{
		private Collective_Agreement_Factor_1_DataType collective_Agreement_Factor_1_DataField;

		private Collective_Agreement_Factor_2_DataType collective_Agreement_Factor_2_DataField;

		private Collective_Agreement_Factor_3_DataType collective_Agreement_Factor_3_DataField;

		private Collective_Agreement_Factor_4_DataType collective_Agreement_Factor_4_DataField;

		private Collective_Agreement_Factor_5_DataType collective_Agreement_Factor_5_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Collective_Agreement_Factor_1_DataType Collective_Agreement_Factor_1_Data
		{
			get
			{
				return this.collective_Agreement_Factor_1_DataField;
			}
			set
			{
				this.collective_Agreement_Factor_1_DataField = value;
				this.RaisePropertyChanged("Collective_Agreement_Factor_1_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Collective_Agreement_Factor_2_DataType Collective_Agreement_Factor_2_Data
		{
			get
			{
				return this.collective_Agreement_Factor_2_DataField;
			}
			set
			{
				this.collective_Agreement_Factor_2_DataField = value;
				this.RaisePropertyChanged("Collective_Agreement_Factor_2_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Collective_Agreement_Factor_3_DataType Collective_Agreement_Factor_3_Data
		{
			get
			{
				return this.collective_Agreement_Factor_3_DataField;
			}
			set
			{
				this.collective_Agreement_Factor_3_DataField = value;
				this.RaisePropertyChanged("Collective_Agreement_Factor_3_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Collective_Agreement_Factor_4_DataType Collective_Agreement_Factor_4_Data
		{
			get
			{
				return this.collective_Agreement_Factor_4_DataField;
			}
			set
			{
				this.collective_Agreement_Factor_4_DataField = value;
				this.RaisePropertyChanged("Collective_Agreement_Factor_4_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Collective_Agreement_Factor_5_DataType Collective_Agreement_Factor_5_Data
		{
			get
			{
				return this.collective_Agreement_Factor_5_DataField;
			}
			set
			{
				this.collective_Agreement_Factor_5_DataField = value;
				this.RaisePropertyChanged("Collective_Agreement_Factor_5_Data");
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
